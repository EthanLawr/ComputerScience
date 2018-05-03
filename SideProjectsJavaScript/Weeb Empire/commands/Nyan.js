const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'nyan',
  ],
  usage: 'nyan',
  description: 'Nyan!',
  category: 'Fun',
  execute: async (client, message) => {
    const nyan = await WeebApi('nyan');
    if (nyan === undefined) return message.channel.send(":cry: I couldn't contact the API...");
    return message.channel.send(new global.Discord.Attachment(nyan));
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
