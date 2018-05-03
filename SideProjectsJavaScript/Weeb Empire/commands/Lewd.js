const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'lewd',
  ],
  usage: 'lewd',
  description: 'LEWD!',
  category: 'Fun',
  execute: async (client, message) => {
    const lewd = await WeebApi('lewd');
    if (lewd === undefined) return message.channel.send(":cry: I couldn't contact the API...");
    return message.channel.send(`Thats so Lewd!`, new global.Discord.Attachment(lewd));
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
