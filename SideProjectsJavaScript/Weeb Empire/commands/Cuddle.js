const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'cuddle',
  ],
  usage: 'cuddle <user>',
  description: 'Cuddle with people!',
  category: 'Fun',
  execute: async (client, message) => {
    const cuddle = await WeebApi('cuddle');
    if (cuddle === undefined) return message.channel.send(":cry: I couldn't contact the API...");

    let target = message.mentions.members.first();
    if (!target || target.id === client.user.id) {
      return message.channel.send(`<@${client.user.id}> cuddled with <@${message.author.id}>!`,
        new global.Discord.Attachment(cuddle));
    }
    if (target.id === message.author.id) {
      return message.channel.send('Thats a bit lonely..... try to cuddle with someone else instead! Like me!');
    }
    return message.channel.send(`<@${message.author.id}> cuddled with <@${target.id}>!`, new global.Discord.Attachment(cuddle));
  },
};
function WeebApi(type) {
  return snekfetch.get(`https://rra.ram.moe/i/r?type=${type}`)
        .then(r => `https://rra.ram.moe${r.body.path}`)
        .catch(err => {
          global.Logger.error(err);
          return undefined;
        });
}
