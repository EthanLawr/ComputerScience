module.exports = {
  commands: [
    'setgame'
  ],
  usage: 'setgame [-t twitch_url] <game name>',
  description: 'Set your playing status.',
  category: 'Utility',
  execute: (client, message, args) => {
    if(args.length < 1) {
      message.edit('Reset your game!');
      client.user.setGame(null, null);

      return;
    }

    if(args[0].toLowerCase() === '-t') {
      if(!args[1].toLowerCase().startsWith('https://twitch.tv/')) {
        return message.edit('Invalid Twitch URL');
      }
      if(args.slice(2).length < 1) {
        return message.edit('No game name was submitted');
      }
      client.user.setPresence({
        game: {
          name: args.slice(2).join(' '),
          url: args[1],
          type: 1
        }
      });
      message.edit(`Set your game to \`${args.slice(2).join(' ')}\``);
    } else {
      client.user.setPresence({
        game: {
          name: args.join(' '),
          type: 0
        }
      });
      message.edit(`Set your game to \`${args.join(' ')}\``);
    }
  }
};
