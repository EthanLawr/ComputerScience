const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'tickle',
  ],
  usage: 'tickle <user>',
  description: 'Tickle people!',
  category: 'Fun',
  execute: async (client, message) => {
    const tickle = await WeebApi('tickle');
    if (tickle === undefined) return message.channel.send(":cry: I couldn't contact the API...");

    let target = message.mentions.members.first();
    if (!target || target.id === client.user.id) {
      return message.channel.send(`<@${client.user.id}> tickled <@${message.author.id}>!`, new global.Discord.Attachment(tickle));
    }
    if (target.id === message.author.id) {
      return message.channel.send('How does one tickle themselves?');
    }
    return message.channel.send(`<@${message.author.id}> tickled <@${target.id}>!`, new global.Discord.Attachment(tickle));
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
