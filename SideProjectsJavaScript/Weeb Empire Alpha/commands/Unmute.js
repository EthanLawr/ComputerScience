module.exports = {
  commands: [
    'unmute',
    'unmoot',
  ],
  usage: 'unmute <user> <reason>',
  description: 'Unmute someone!',
  category: 'Moderation',
  execute: (client, message, args) => {
    if (message.member.roles.find('name', 'Co Pervert') || message.member.roles.find('name', 'Community Manager') ||
     message.member.roles.find('name', 'Head Staff') || message.member.roles.find('name', 'Admin Extreme') ||
      message.member.roles.find('name', 'Admin') || message.member.roles.find('name', 'Mod Extreme') ||
       message.member.roles.find('name', 'Moderator') || message.member.roles.find('name', 'Staff')) {
      let target = message.mentions.members.first();
      let muteRole = message.guild.roles.get('359827967989383168');
      if (!target) return message.reply('Please mention a valid member of this server');
      if (!muteRole) return message.reply('Please create a mute role named `Muted`!');

      let reason = args.slice(1).join(' ');
      if (reason.length > 100) reason = `${reason.substring(0, 900)} ...`;
      if (!reason) reason = 'No reason provided';
      if (!target.roles.find('name', 'Muted')) return message.channel.send('This user is already unmuted!');
      target.removeRole(muteRole).catch(error => message.reply(`Sorry ${message.author} I couldn't unmute because: ${error}`));
      message.channel.send(`Successfully unmuted <@${target.user.id}>`);

      let sembed = new global.Discord.RichEmbed()
      .setColor(3335333)
      .setTimestamp()
      .setTitle('Action: Unmute')
      .setThumbnail(target.user.displayAvatarURL || 'https://i.imgur.com/TFdnp8i.png')
      .addField('User:', `${target.user.tag} (<@${target.id}>)`)
      .addField('Moderator:', `${message.author.tag} (<@${message.author.id}>)`)
      .addField('Reason:', `${reason}`);

      return global.Mordant.channels.get('428388957987012613').send({ embed: sembed });
    } else {
      return message.reply('Sorry, you must atleast be a `Moderator` to use this command!');
    }
  },
};
