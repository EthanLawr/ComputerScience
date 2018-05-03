module.exports = {
  commands: [
    'underage',
    'ua',
  ],
  usage: 'underage <user>',
  description: 'Give the `Under 18` role to someone!',
  category: 'Moderation',
  execute: (client, message) => {
    if (message.member.roles.find('name', 'Co Pervert') || message.member.roles.find('name', 'Community Manager') ||
     message.member.roles.find('name', 'Head Staff') || message.member.roles.find('name', 'Admin Extreme') ||
      message.member.roles.find('name', 'Admin') || message.member.roles.find('name', 'Mod Extreme') ||
       message.member.roles.find('name', 'Moderator') || message.member.roles.find('name', 'Staff')) {
      let target = message.mentions.members.first();
      let underAgeRole = message.guild.roles.get('413423384995561503');
      if (!target) return message.reply('Please mention a valid member of this server');
      if (target.roles.find('name', 'Under 18')) return message.channel.send('This user already has the `Under 18` role!');
      target.addRole(underAgeRole).catch(error => message.reply(`Sorry ${message.author} I couldn't add the role because: ${error}`));
      message.channel.send(`Successfully gave \`Under 18\` to <@${target.user.id}>`);
      let sembed = new global.Discord.RichEmbed()
      .setColor(3335333)
      .setTimestamp()
      .setTitle('Action: Underage')
      .setThumbnail(target.user.displayAvatarURL || 'https://i.imgur.com/TFdnp8i.png')
      .addField('User:', `${target.user.tag} (<@${target.id}>)`)
      .addField('Moderator:', `${message.author.tag} (<@${message.author.id}>)`);

      return global.Mordant.channels.get('428388957987012613').send({ embed: sembed });
    } else {
      return message.reply('Sorry, you must atleast be a `Moderator` to use this command!');
    }
  },
};
