const snekfetch = require('snekfetch');
const { RichEmbed } = require('discord.js');
const config = require('../config');

module.exports = {
	commands: [
		'neko',
		'nekos'
	],
	usage: 'neko',
	description: 'OwO',
	category: 'Fun',
	execute: (client, message) => {
		snekfetch.get('https://nekos.life/api/neko').then((res) => {
		if (res.status !== 200) {
			return message.channel.send('An error has occurred!');
		}

		message.edit('', {
			embed: new RichEmbed()
				.setColor(config.discord.defaultColor)
				.setTitle('Random Neko')
				.setDescription('This message will be deleted in 3 minutes')
				.setImage(res.body.neko)
				.setFooter(`${client.config.strings.github}`)
		}).then(message.delete(180000));;
		});
	}
};
