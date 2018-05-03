const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'pat',
  ],
  usage: 'pat <user>',
  description: 'Pat people!',
  category: 'Fun',
  execute: async (client, message) => {
    let target = message.mentions.members.first();
    const res = await snekfetch.get('https://nekos.life/api/pat').set('Key', 'dnZ4fFJbjtch56pNbfrZeSRfgWqdPDgf');
    if (!target || target.id === client.user.id) {
      return message.channel.send(`<@${client.user.id}> patted <@${message.author.id}>!`,
        new global.Discord.Attachment(res.body.url));
    }
    if (target.id === message.author.id) {
      return message.channel.send('Here I\'ll pat you instead! ***pat pat pat***', new global.Discord.Attachment(res.body.url));
    }
    return message.channel.send(`<@${message.author.id}> patted <@${target.id}>!`, new global.Discord.Attachment(res.body.url));
  },
};
