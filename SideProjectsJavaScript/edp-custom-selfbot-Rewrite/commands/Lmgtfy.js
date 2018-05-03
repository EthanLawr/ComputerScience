const Logger = require('../functions/logger');

module.exports = {
	commands: [
		'lmgtfy',
   		'lmg'
	],
	usage: 'lmgtfy <content>',
	description: 'Learning to use google',
	category: 'Fun',
	execute: (client, message, args) => {
		Logger.cmd("Lmgtfy");
		if (!args[0]) {
			return message.edit('You must provide something to search for!');
		} else {
			message.edit(`Heres how you google this! http://www.lmgtfy.com/?q=${args.join('+')}`);
		}
	}
};