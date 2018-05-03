const util = require('util');
const Logger = require('../functions/logger');

module.exports = {
	commands: [
		'reload'
	],
	usage: 'reload <command>',
	description: 'Reloads a command from inside the client.',
	category: 'Utility',
	execute: (client, message, args) => {
		if (args.length > 0) {
			const filtered = Object.keys(client.commands).filter((c) => args[0] === c || client.commands[c].commands.indexOf(args[0]) > -1);
		if (filtered.length > 0) {
			const old = Object.create(client.commands[filtered[0]]);
			delete client.commands[filtered[0]];
			delete require.cache[require.resolve('./' + filtered[0] + '.js')];
        try {
			client.commands[filtered[0]] = require('./' + filtered[0] + '.js');
			message.edit('Successfully reloaded command `' + client.commands[filtered[0]].commands[0] + '`.');
			Logger.debug('Reloaded ' + client.commands[filtered[0]].commands[0]);
        } catch(error) {
			message.edit('An error occured while assigning command to self. Restoring in-memory command to before reload.\n```js\n' + util.inspect(error) + '```');
			Logger.warn(util.inspect(error));
			delete client.commands[filtered[0]];
			client.commands[filtered[0]] = old;
        }
		} else {
			message.edit('That is not a valid command name.');
			Logger.warn('That is not a valid command name.');
		}
		} else {
			message.edit('Missing a command to reload.');
			Logger.warn('Missing a command to reload.');
		}
	}
};
