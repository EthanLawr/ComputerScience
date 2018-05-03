const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'kiss',
  ],
  usage: 'kiss <user>',
  description: 'Kiss people!',
  category: 'Fun',
  execute: async (client, message) => {
    let target = message.mentions.members.first();
    const res = await snekfetch.get('https://nekos.life/api/kiss').set('Key', 'dnZ4fFJbjtch56pNbfrZeSRfgWqdPDgf');
    if (!target) {
      return message.channel.send(`<@${client.user.id}> gave <@${message.author.id}> a kiss!`,
        new global.Discord.Attachment(res.body.url));
    }
    if (target.id === message.author.id) {
      return message.channel.send('Thats a bit lonely..... try to kiss someone else instead! Like me!');
    }
    return message.channel.send(`<@${message.author.id}> gave <@${target.id}> a kiss!`,
      new global.Discord.Attachment(res.body.url));
  },
};
