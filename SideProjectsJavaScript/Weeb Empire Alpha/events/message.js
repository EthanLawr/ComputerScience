const util = require('util');
module.exports = (client, message) => {
  if (message.content.toLowerCase() === '<@430445404153446410>' || message.content.toLowerCase() === '<@!430445404153446410>') {
    message.reply('My prefix is `!-` <:vohiyo:409226877836722176>');
    return;
  }
  if (!message.content.startsWith(global.config.discord.prefix)) {
    return;
  } 
  const command = Object.keys(client.commands.Fun).filter(c => client.commands[c]
    .commands.indexOf(message.content.replace(global.config.discord.prefix, '').split(' ')[0]) > -1);
  if (command.length > 0) {
    const args = message.content.replace(global.config.discord.prefix, '')
    .split(' ').length > 1 ? message.content.replace(global.config.discord.prefix, '').split(' ').slice(1) : [];
    try {
      global.Logger.cmd(`${command} was used by ${message.author.tag}`);
      client.commands[command[0]].execute(client, message, args);
      /* let embed = new Discord.RichEmbed()
      .setColor(3335333)
      .setTimestamp()
      .setTitle(`Action: ${command}`)
      .setThumbnail(message.author.displayAvatarURL || 'https://i.imgur.com/TFdnp8i.png')
      .addField('Moderator:', `${message.author.tag} (<@${message.author.id}>)`);
      global.moderationLoggingHelp.send(embed);*/
    } catch (error) {
      let toSend = `An error has occured running that command.\`\`\`js\n${util.inspect(error)}\`\`\``;
      if (toSend.length > 1900) {
        message.channel.send('An error has occured running that command and the output has been logged to console.');
        throw new Error(util.inspect(error));
      } else {
        message.channel.send(toSend);
        throw new Error(util.inspect(error));
      }
    }
  }
};
