const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'slap',
  ],
  usage: 'slap <user>',
  description: 'Slap people!',
  category: 'Fun',
  execute: async (client, message) => {
    const slap = await WeebApi('slap');
    if (slap === undefined) return message.channel.send(":cry: I couldn't contact the API...");

    let target = message.mentions.members.first();
    if (!target || target.id === client.user.id) {
      return message.channel.send(`<@${client.user.id}> slapped <@${message.author.id}>!`,
        new global.Discord.Attachment(slap));
    }
    if (target.id === message.author.id) {
      return message.channel.send('Err don\'t slap youself...');
    }
    return message.channel.send(`<@${message.author.id}> slapped <@${target.id}>!`, new global.Discord.Attachment(slap));
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
