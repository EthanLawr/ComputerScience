module.exports = {
  commands: [
    'fuck',
  ],
  usage: 'fuck <user>',
  description: 'Fuck people!',
  category: 'Fun',
  execute: (client, message) => {
    let target = message.mentions.members.first();
    let fuckGif = Math.floor(Math.random() * 21);
    fuckGif = `./images/Fuck/${fuckGif}.gif`;
    if (!message.channel.nsfw) {
      return message.channel.send('You must be in a channel labeled as `NSFW` to use this command!');
    }
    if (!target || target.id === client.user.id) {
      return message.channel.send(`<@${client.user.id}> fucked <@${message.author.id}>`,
        new global.Discord.Attachment(fuckGif));
    }
    if (target.id === message.author.id) {
      return message.channel.send('Thats a bit lonely..... try to fuck someone instead! Like me!');
    }
    return message.channel.send(`<@${message.author.id}> fucked <@${target.id}>!`,
      new global.Discord.Attachment(fuckGif));
  },
};
