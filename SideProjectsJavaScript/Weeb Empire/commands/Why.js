const snekfetch = require('snekfetch');
const questionImages = ['https://i.imgur.com/t4P0YCF.png', 'https://i.imgur.com/wl8WAwO.png', 'https://i.imgur.com/eEi7Swr.png',
  'https://i.imgur.com/ZplrtzO.png', 'https://i.imgur.com/MkPW8pC.png', 'https://i.imgur.com/4zGGXE8.png',
  'https://i.imgur.com/3P8VtKU.png', 'https://i.imgur.com/q5TIz6m.png'];
function jsUppperCase(string) { return string.charAt(0).toUpperCase() + string.slice(1); }

module.exports = {
  commands: [
    'why',
  ],
  usage: 'why',
  description: 'Just why',
  category: 'Fun',
  execute: async (client, message) => {
    let embed = new global.Discord.RichEmbed()
    .setColor(3335333)
    .setTimestamp()
    .setTitle(jsUppperCase(await snekfetch.get('https://nekos.life/api/why')
    .set('Key', 'dnZ4fFJbjtch56pNbfrZeSRfgWqdPDgf').then(r => r.body.why)))
    .setAuthor(message.author.tag, message.author.avatarURL)
    .setThumbnail(questionImages[Math.floor(questionImages.length * Math.random())]);
    return message.channel.send(embed);
  },
};
