/* eslint complexity: ["off"]*/
const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'dog',
  ],
  usage: 'dog',
  description: 'Dogs!',
  category: 'Fun',
  execute: (client, message) => {
    snekfetch.get('http://random.dog/woof.json').then(r => {
      message.channel.send(new global.Discord.Attachment(r.body.url));
    });
  },
};
