const snekfetch = require('snekfetch');
module.exports = {
  commands: [
    'hug',
  ],
  usage: 'hug <user>',
  description: 'Hug people!',
  category: 'Fun',
  execute: async (client, message) => {
    let target = message.mentions.members.first();
    const res = await snekfetch.get('https://nekos.life/api/hug').set('Key', 'dnZ4fFJbjtch56pNbfrZeSRfgWqdPDgf');
    if (!target || target.id === client.user.id) {
      return message.channel.send(`<@${client.user.id}> gave <@${message.author.id}> a hug!`,
        new global.Discord.Attachment(res.body.url, 'hi.gif'));
    }
    if (target.id === message.author.id) {
      return message.channel.send('Thats a bit lonely..... try to hug someone else instead! Like me!');
    }
    return message.channel.send(`<@${message.author.id}> gave <@${target.id}> a hug!`,
      new global.Discord.Attachment(res.body.url));
  },
};
