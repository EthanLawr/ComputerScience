const ms = require('ms');
module.exports = {
  commands: [
    'mute',
    'moot',
  ],
  usage: 'mute <user> <time> <reason>',
  description: 'Mute someone!',
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

      let muteTime = args[1];
      let reason = args.slice(2).join(' ');
      if (!muteTime) muteTime = '600000';
      if (!muteTime.match(/^\d/)) {
        muteTime = '600000';
        reason = args.slice(1).join(' ');
      }
      if (ms(muteTime) > 604800000) return message.channel.send('Please enter a time of 1 week or less');
      if (reason.length > 100) reason = `${reason.substring(0, 900)} ...`;
      if (!reason) reason = 'No reason provided';
      if (target.roles.find('name', 'Muted')) return message.channel.send('This user is already muted!');
      target.addRole(muteRole).catch(error => message.reply(`Sorry ${message.author} I couldn't mute because: ${error}`));
      message.channel.send(`Successfully muted <@${target.user.id}> for ${ms(ms(muteTime), { long: true })}`);
      setTimeout(() => {
        target.removeRole(muteRole).catch(error => message.reply(`Sorry ${message.author}, ` +
          `I couldn't unmute <@${target.id}> because: ${error}`));
        return target.send(`You have been unmuted in ${message.guild.name}.`);
      }, ms(muteTime));
      let sembed = new global.Discord.RichEmbed()
      .setColor(3335333)
      .setTimestamp()
      .setTitle('Action: Timed Mute')
      .setThumbnail(target.user.displayAvatarURL || 'https://i.imgur.com/TFdnp8i.png')
      .addField('User:', `${target.user.tag} (<@${target.id}>)`)
      .addField('Moderator:', `${message.author.tag} (<@${message.author.id}>)`)
      .addField('Muted for:', ms(ms(muteTime), { long: true }))
      .addField('Reason:', `${reason}`);
      return global.Mordant.channels.get('428388957987012613').send({ embed: sembed });
    } else {
      return message.reply('Sorry, you must atleast be a `Moderator` to use this command!');
    }
  },
};
