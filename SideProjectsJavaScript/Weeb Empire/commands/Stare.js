const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'stare',
  ],
  usage: 'stare <user>',
  description: 'Stare at people!',
  category: 'Fun',
  execute: async (client, message) => {
    const stare = await WeebApi('stare');
    if (stare === undefined) return message.channel.send(":cry: I couldn't contact the API...");

    let target = message.mentions.members.first();
    if (!target || target.id === client.user.id) {
      return message.channel.send(`<@${client.user.id}> stared at <@${message.author.id}>!`, new global.Discord.Attachment(stare));
    }
    if (target.id === message.author.id) {
      return message.channel.send('There are no mirrors around here... so you can\'t really do that....');
    }
    return message.channel.send(`<@${message.author.id}> stared at <@${target.id}>!`, new global.Discord.Attachment(stare));
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
