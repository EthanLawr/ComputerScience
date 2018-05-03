const util = require('util');

module.exports = {
  commands: [
    'reload',
  ],
  usage: 'reload <command>',
  description: 'Reloads a command from inside the Stan National Basement.',
  category: 'Owner',
  execute: (client, message, args) => {
    if (message.author.id === '250815960250974209') {
      if (args.length > 0) {
        const filtered = Object.keys(client.commands).filter(c => args[0] === c || client.commands[c].commands.indexOf(args[0]) > -1);
        if (filtered.length > 0) {
          const old = Object.create(client.commands[filtered[0]]);
          delete client.commands[filtered[0]];
          delete require.cache[require.resolve(`./${filtered[0]}.js`)];
          try {
            client.commands[filtered[0]] = require(`./${filtered[0]}.js`);
            message.channel.send(`Successfully reloaded command \`${client.commands[filtered[0]].commands[0]}\`.`);
            global.Logger.debug(`Reloaded ${client.commands[filtered[0]].commands[0]}`);
          } catch (error) {
            message.channel.send('An error occured while assigning command to self. Restoring in-memory command' +
						` to before reload.\n\`\`\`js\n${util.inspect(error)}\`\`\``);
            global.Logger.warn(util.inspect(error));
            delete client.commands[filtered[0]];
            client.commands[filtered[0]] = old;
          }
        } else {
          message.channel.send('That is not a valid command name.');
          global.Logger.warn('That is not a valid command name.');
        }
      } else {
        message.channel.send('Missing a command to reload.');
        global.Logger.warn('Missing a command to reload.');
      }
    } else {
      message.channel.send('Only Evildeathpro can do this! Please contact him if it needs to be done!');
    }
  },
};
