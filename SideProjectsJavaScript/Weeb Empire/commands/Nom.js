const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'nom',
  ],
  usage: 'nom',
  description: 'Nom!',
  category: 'Fun',
  execute: async (client, message) => {
    const nom = await WeebApi('nom');
    if (nom === undefined) return message.channel.send(":cry: I couldn't contact the API...");
    return message.channel.send(new global.Discord.Attachment(nom));
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
