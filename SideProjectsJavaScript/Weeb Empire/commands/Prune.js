module.exports = {
  commands: [
    'prune',
    'purge',
    'clear',
  ],
  usage: 'prune <integer>',
  description: 'Prune messages!',
  category: 'Moderation',
  execute: async(client, message, args) => {
    if (message.member.roles.find('name', 'Co Pervert') || message.member.roles.find('name', 'Community Manager') ||
     message.member.roles.find('name', 'Head Staff') || message.member.roles.find('name', 'Admin Extreme') ||
      message.member.roles.find('name', 'Admin') || message.member.roles.find('name', 'Mod Extreme') ||
       message.member.roles.find('name', 'Moderator') || message.member.roles.find('name', 'Staff')) {
      let nmsgs = parseInt(args[0]);
      if (nmsgs.toString() !== args[0]) return message.reply(`Please enter a valid number of messages to clear.`);

      let result;
      try {
        if (++nmsgs >= 100) {
          nmsgs = 100;
          await message.channel.bulkDelete(nmsgs);
          let overload = await message.reply(`The maximum amount of msgs I can delete is 99!`);
          setTimeout(() => overload.delete(), 7500);
        } else {
          await message.channel.bulkDelete(nmsgs);
        }
        result = await message.reply(`${--nmsgs} message(s) deleted successfully!`);
      } catch (err) {
        result = await message.reply(`Could not delete ${args[0]} message(s)..`);
      }
      let sembed = new global.Discord.RichEmbed()
      .setColor(3335333)
      .setTimestamp()
      .setTitle('Action: Prune')
      .setThumbnail(message.author.displayAvatarURL || 'https://i.imgur.com/TFdnp8i.png')
      .addField('Moderator:', `${message.author.tag} (<@${message.author.id}>)`)
      .addField(`Channel: #${message.channel.name}`, `Messages Deleted: ${nmsgs}`);

      global.Mordant.channels.get('428388957987012613').send({ embed: sembed });
      return setTimeout(() => result.delete(), 9500);
    } else {
      return message.reply('Sorry, you must atleast be a `Moderator` to use this command!');
    }
  },
};
