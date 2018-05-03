module.exports = {
  commands: [
    'softban',
  ],
  usage: 'softban <user> <reason>',
  description: 'Softban a user!',
  category: 'Moderation',
  execute: async(client, message, args) => {
    if (message.member.roles.find('name', 'Co Pervert') || message.member.roles.find('name', 'Community Manager') ||
     message.member.roles.find('name', 'Head Staff') || message.member.roles.find('name', 'Admin Extreme') ||
      message.member.roles.find('name', 'Admin')) {
      let target = message.mentions.members.first();
      if (!target) return message.reply('Please mention a valid member of this server');
      if (!target.bannable) return message.reply('I cannot softban this user!');
      let reason = args.slice(1).join(' ');
      if (reason.length > 100) reason = `${reason.substring(0, 900)} ...`;
      if (!reason) reason = 'No reason provided';
      await target.ban(1, reason).catch(error => message.reply(`Sorry ${message.author} I couldn't softban because: ${error}`)).then(() => {
        message.guild.unban(target.id).catch(error => message.reply(`Sorry ${message.author} I couldn't unban because: ${error}`));
      });

      let sembed = new global.Discord.RichEmbed()
      .setColor(9109504)
      .setTimestamp()
      .setTitle('Action: Softban')
      .setThumbnail(target.user.displayAvatarURL || 'https://i.imgur.com/TFdnp8i.png')
      .addField('User:', `${target.user.tag} (<@${target.id}>)`)
      .addField('Moderator:', `${message.author.tag} (<@${message.author.id}>)`)
      .addField('Reason:', `${reason}`);

      global.Mordant.channels.get('428388957987012613').send({ embed: sembed });
      return message.channel.send(`<@${target.user.id}> has been softbanned by <@${message.author.id}> because: \`${reason}\``);
    } else {
      return message.reply('Sorry, you must atleast be an `Admin` to use this command!');
    }
  },
};
