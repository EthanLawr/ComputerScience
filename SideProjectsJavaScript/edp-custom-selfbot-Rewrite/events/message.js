const config = require('../config.json');
const Logger = require('../functions/logger');
const util = require('util');

module.exports = (client, message) => {
	
	if(message.author.id !== client.user.id) {
		return;
	}
	if(!message.content.startsWith(config.discord.prefix)) {
		return;
	}
	const command = Object.keys(client.commands).filter((command) => client.commands[command].commands.indexOf(message.content.replace(config.discord.prefix, '').split(' ')[0]) > -1);
	if (command.length > 0) {
		const args = message.content.replace(config.discord.prefix, '').split(' ').length > 1 ? message.content.replace(config.discord.prefix, '').split(' ').slice(1) : [];
		try {
			Logger.cmd(`${command}`);
			client.commands[command[0]].execute(client, message, args);
		} catch(error) {
			let toSend = 'An error has occured running that command.```js\n' + util.inspect(error) + '```';
			if(toSend.length > 1900) {
				message.edit('An error has occured running that command and the output has been logged to console.');
				throw new Error(error);
			} else {
				message.edit(toSend);
				throw new Error(error);
			}
		}
	}
};