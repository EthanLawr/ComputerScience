const { RichEmbed } = require('discord.js');
const config = require('../config');

module.exports = {
	commands: [
	'help',
	'helpme'
	],
	usage: 'help [command]',
	description: 'View a list of commands or get information about a specific command.',
	category: 'Information',
	execute: (client, message, args) => {
    if (args.length > 0) {
		const command = Object.keys(client.commands).filter((c) => client.commands[c].commands.indexOf(args[0]) > -1);
	if (command.length > 0) {
		const embed = new RichEmbed()
			.setTitle('Command Information', '')
			.setDescription('This message will be deleted in 3 minutes')
			.setColor(config.discord.defaultColor)
			.addField('Name', client.commands[command[0]].commands[0])
			.addField('Description', client.commands[command[0]].description)
			.addField('Usage', client.commands[command[0]].usage)
			.addField('Aliases', client.commands[command[0]].commands.length > 1 ? client.commands[command[0]].commands.slice(1).join(', ') : 'No Aliases')
			.setFooter(client.config.strings.github)
			.setTimestamp();
        message.edit({ embed }).then(message.delete(180000));
	} else {
		const embed = new RichEmbed()
			.setTitle('Command List')
			.setDescription('This message will be deleted in 3 minutes')
			.setColor(config.discord.defaultColor)
			.setDescription('That is not a command that I know of.')
			.setFooter(client.config.strings.github)
			.setTimestamp();
        message.edit({ embed }).then(message.delete(180000));
	}
    } else {
		let listThing = {};
		Object.keys(client.commands).forEach((command) => {
			if (client.commands[command].category in listThing) {
				listThing[client.commands[command].category] += '\n' + client.commands[command].commands[0] + ' - ' + client.commands[command].description;
			} else {
				listThing[client.commands[command].category] = client.commands[command].commands[0] + ' - ' + client.commands[command].description;
			}
		});
		const embed2 = new RichEmbed()
			.setTitle('Command List')
			.setDescription('This message will be deleted in 3 minutes')
			.setColor(config.discord.defaultColor)
			.setDescription(Object.keys(listThing).map((command) => '__' + command + '__\n' + listThing[command]).join('\n\n'))
			.setFooter(client.config.strings.github)
			.setTimestamp();
		message.edit({ embed: embed2 }).then(message.delete(180000));
    }}
};
