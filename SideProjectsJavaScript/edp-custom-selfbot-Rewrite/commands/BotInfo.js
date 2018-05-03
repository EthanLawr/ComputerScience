const snekfetch = require('snekfetch');
const { RichEmbed } = require('discord.js');
const config = require('../config');

module.exports = {
	commands: [
		'botinfo'
	],
	usage: 'botinfo <bot ID>',
	description: 'Pull Information on a bot from https://discordbots.org.',
	category: 'Information',
	execute: (client, message, args) => {
		if(args.length < 1) {
			return message.edit('Please provide a bot ID');
		}

		let id = 0;

		if(message.mentions.users.first()) {
			id = message.mentions.users.first().id;
		} else {
			id = args[0];
		}

		snekfetch.get('https://discordbots.org/api/bots/' + id).then((res) => {
		const embed = new RichEmbed()
			.setColor(config.discord.defaultColor)
			.setTimestamp()
			.setTitle('Bot Info')
			.setDescription('This message will be deleted in 3 minutes')
			.setFooter(client.config.strings.github)
			.setThumbnail(`https://cdn.discordapp.com/avatars/${id}/a_${res.body.avatar}.webp`)
			.addField('ID', id)
			.addField('Tag', `${res.body.username}#${res.body.discriminator}`, true)
			.addField('Short Description', res.body.shortdesc)
			.addField('Library', res.body.lib, true)
			.addField('Prefix', res.body.prefix)
			.addField('Upvotes', res.body.points, true)
			.addField('Server Count', typeof res.body.server_count === 'number' ? res.body.server_count : 'This bot doesn\'t post server count!', true)
			.addField('Owner(s)', '<@' + res.body.owners.join('>\n<@') + '>')
			.addField('Invite', '[Here](https://discordapp.com/oauth2/authorize?scope=bot&permissions=0&client_id=' + id + ')', true);
		message.edit('', { embed }).then(message.delete(180000));
		}).catch(() => {
			return message.edit('The bot you are looking for was not found!');
		});
	}
};
