const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'lick',
  ],
  usage: 'lick <user>',
  description: 'Lick people!',
  category: 'Fun',
  execute: async (client, message) => {
    const lick = await WeebApi('lick');
    if (lick === undefined) return message.channel.send(":cry: I couldn't contact the API...");

    let target = message.mentions.members.first();
    if (!target || target.id === client.user.id) {
      return message.channel.send(`<@${client.user.id}> licked <@${message.author.id}>!`,
        new global.Discord.Attachment(lick));
    }
    if (target.id === message.author.id) {
      return message.channel.send('Why would you try to lick yourself?');
    }
    return message.channel.send(`<@${message.author.id}> licked <@${target.id}>!`, new global.Discord.Attachment(lick));
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
