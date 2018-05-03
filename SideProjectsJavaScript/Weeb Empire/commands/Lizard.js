const snekfetch = require('snekfetch');

module.exports = {
  commands: [
    'lizard',
    'lizards',
  ],
  usage: 'lizard',
  description: 'Lizards!! :lizard:',
  category: 'Fun',
  execute: (client, message) => {
    snekfetch.get('https://nekos.life/api/lizard').then(res => {
      if (res.status !== 200) {
        return message.channel.send('An error has occurred!');
      }
      return message.channel.send(new global.Discord.Attachment(res.body.url));
    });
  },
};
