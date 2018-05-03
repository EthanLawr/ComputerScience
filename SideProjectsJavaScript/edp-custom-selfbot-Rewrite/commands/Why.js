const snekfetch = require('snekfetch');
const { RichEmbed } = require('discord.js');

module.exports = {
	commands: [
		'why',
		'butwhy',
		'justwhy'
	],
	usage: 'why',
	description: 'Why would you do that....',
	category: 'Fun',
	execute: (client, message) => {
		snekfetch.get('https://nekos.life/api/why').then((res) => {
		if (res.status !== 200) {
			return message.channel.send('**An error has occurred!**');
		}

		message.edit(`${res.body.why}`);
		});
    }
};