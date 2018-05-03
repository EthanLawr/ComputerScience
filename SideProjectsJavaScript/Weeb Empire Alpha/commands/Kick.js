/*	"one": "359852759991844864",
	"one": "359852759991844864",
	"one": "359852759991844864",
	"one": "359852759991844864",
	"one": "359852759991844864",*/
module.exports = {
  commands: [
    'kick',
  ],
  usage: 'kick <user> <reason>',
  description: 'Kick a user!',
  category: 'Moderation',
  execute: async(client, message, args) => {
    if (message.member.roles.get(global.config.tiers.one) || message.member.roles.find('name', 'Community Manager') ||
     message.member.roles.find('name', 'Head Staff') || message.member.roles.find('name', 'Admin Extreme') ||
      message.member.roles.find('name', 'Admin') || message.member.roles.find('name', 'Mod Extreme')) {
      let target = message.mentions.members.first();
      if (!target) return message.reply('Please mention a valid member of this server');
      if (!target.kickable) return message.reply('I cannot kick this user!');
      let reason = args.slice(1).join(' ');
      if (reason.length > 100) reason = `${reason.substring(0, 900)} ...`;
      if (!reason) reason = 'No reason provided';
      await target.kick(reason).catch(error => message.reply(`Sorry ${message.author} I couldn't kick because: ${error}`));

      let embed = new global.Discord.RichEmbed()
      .setColor(9109504)
      .setTimestamp()
      .setTitle('Action: Kick')
      .setThumbnail(target.user.displayAvatarURL || 'https://i.imgur.com/TFdnp8i.png')
      .addField('User:', `${target.user.tag} (${target.id})`)
      .addField('Moderator:', `${message.author.tag} (${message.author.id})`)
      .addField('Reason:', `${reason}`);

      global.Mordant.channels.get('428388957987012613').send(embed);
      return message.reply(`<@${target.user.id}> has been kicked by <@${message.author.id}> because: \`${reason}\``);
    } else {
      return message.reply('Sorry, you must atleast be a `Moderator Extreme` to use this command!');
    }
  },
};
