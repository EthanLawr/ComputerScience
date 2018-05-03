const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'pout',
  ],
  usage: 'pout',
  description: 'Pout!',
  category: 'Fun',
  execute: async (client, message) => {
    const pout = await WeebApi('pout');
    if (pout === undefined) return message.channel.send(":cry: I couldn't contact the API...");
    return message.channel.send(new global.Discord.Attachment(pout));
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
