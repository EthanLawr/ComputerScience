const InfoMenu = 'Ping - Shows the ping of the bot.';
const FunCommands = ['Cat - Make some cats!', 'Cry - Cri', 'Cuddle - Cuddle with someone!', 'Dog - Dogs!',
  'Hug - Hugs a user.', 'Kiss - Kisses a user.', 'Lewd - LEWDDD!', 'Lizard - :lizard:', 'Lick - Lick someone!',
  'Nom - Nom nom nom!', 'Nyan - Nyaa!', 'OwO - OwO', 'Pat - Pats a user.', 'Pout - Pout!', 'Rip - Makes a gravestone with text.',
  'Roulette - Play a game of Russian Roulette!', 'Rps - Rock paper scissors!', 'Sepia - Adds a sepia filter to an image.',
  'Slap - Slap someone!', 'Smug - Be smug my child...', 'Stare - Stare at them...', 'Tickle - Tickle tickle tickle!',
  'Triggered - TRIGGERED!!!', 'Why - Just. Why.'];
const ModCommands = ['Mute - Mutes a user', 'Permamute - Permanently mutes a user', 'Prune - Prunes messages.',
  'Underage - Gives a member the `Under 18` role', 'Unmute - Unmutes a user.', 'Warn - Warns someone.'];
const ModCommandsTier2 = ['Ban - Bans a user', 'Kick - Kicks a user.', 'Mute - Mutes a user',
  'Permamute - Permanently mutes a user', 'Prune - Prunes messages.', 'Softban - Bans a user, then unbans them.',
  'Underage - Gives a member the `Under 18` role', 'Unmute - Unmutes a user.', 'Warn - Warns someone.'];
module.exports = {
  commands: [
    'help',
  ],
  usage: 'help <command>',
  description: 'View a list of commands or get information about a specific command',
  category: 'Information',
  execute: (client, message, args) => {
    if (args.length > 0) {
      const command = Object.keys(client.commands).filter(c => client.commands[c].commands.indexOf(args[0]) > -1);
      if (command.length > 0) {
        const embed = new global.Discord.RichEmbed()
          .setTitle('Command Information', '')
          .setColor(global.config.discord.defaultColor)
          .addField('Name', client.commands[command[0]].commands[0])
          .addField('Description', client.commands[command[0]].description)
          .addField('Usage', client.commands[command[0]].usage)
          .addField('Aliases', client.commands[command[0]].commands.length > 1 ?
            client.commands[command[0]].commands.slice(1).join(', ') : 'No Aliases')
          .setTimestamp();
        message.channel.send({ embed });
      } else {
        const embed = new global.Discord.RichEmbed()
          .setTitle('Command List')
          .setColor(global.config.discord.defaultColor)
          .setDescription('That is not a command that I know of.')
          .setTimestamp();
        message.channel.send({ embed });
      }
    } else {
      const embed2 = new global.Discord.RichEmbed()
        .setTitle('Command List')
        .setColor(global.config.discord.defaultColor)
        .addField('Info', InfoMenu)
        .addField('Fun', FunCommands.join('\n'))
        .addField('Moderation', ModCommands.join('\n'))
        .setTimestamp();
      message.channel.send(embed2).then(message.delete(180000));
    }
  },
};
