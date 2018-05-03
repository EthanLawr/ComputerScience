module.exports = {
  commands: [
    'restart',
    'shutdown',
    'sd',
  ],
  usage: 'restart',
  description: 'Restarts the bot',
  category: 'Owner',
  execute: async (client, message) => {
    if (message.author.id === '250815960250974209') {
      await message.reply('Restarting!');
      return process.exit(-100);
    } else {
      return message.channel.send('Only Evildeathpro can do this! Please contact him if it needs to be done!');
    }
  },
};
