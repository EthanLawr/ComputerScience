const snekfetch = require('snekfetch');
const { RichEmbed } = require('discord.js');
const config = require('../config');

module.exports = {
	commands: [
		'lizard',
		'lizards'
	],
	usage: 'lizard',
	description: 'Lizards!! :lizard:',
	category: 'Fun',
	execute: (client, message) => {
		snekfetch.get('https://nekos.life/api/lizard').then((res) => {
		if (res.status !== 200) {
			return message.channel.send('An error has occurred!');
		}

		message.edit('', {
			embed: new RichEmbed()
				.setColor(config.discord.defaultColor)
				.setTitle('Random Lizards')
				.setDescription('This message will be deleted in 3 minutes')
				.setImage(res.body.url)
				.setFooter(`${client.config.strings.github}`)
		}).then(message.delete(180000));
		});
	}
};
