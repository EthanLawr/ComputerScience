const dateFormat = require('dateformat');
const { RichEmbed } = require('discord.js');
const config = require('../config');

module.exports = {
	commands: [
		'userinfo',
		'uinfo'
	],
	usage: 'userinfo <user mention or id>',
	description: 'Get information about a user.',
	category: 'Information',
	execute: (client, message, args, name) => {
		if(!message.guild) {
			return message.edit('This command can only be used in a server');
		}
		if(args.length < 1) {		
			const embed = new RichEmbed()
				.setTitle(`${message.author.tag} | ${message.author.id}`)
				.setDescription('This message will be deleted in 3 minutes')
				.setColor(config.discord.defaultColor)
				.addField('Status', `${message.author.presence.status[0].toUpperCase() + message.author.presence.status.slice(1)}`, true)
				.addField('Game', `${(message.author.presence.game && message.author.presence.game && message.author.presence.game.name) || 'Not playing a game.'}`, true)
				.addField('Created On', `${dateFormat(message.author.createdAt)}`, true)
				.addField('Joined On', `${dateFormat(message.author.joinedAt)}`, true)
				.setFooter(client.config.strings.github)
				.setThumbnail(message.author.avatarURL)
				.setTimestamp();
			return message.edit({ embed }).then(message.delete(180000));
		}
		let user = client.users.get((message.mentions.users.first() && message.mentions.users.first().id) || args[0]);
		if(!user) {
			return message.edit('A user with that ID was not found!');
		}
		let member = message.guild.members.get(user.id);
		if(!member) {
		return message.edit('A user with that ID was not found!');
		}
		const millisCreated = new Date().getTime() - user.createdAt.getTime();
		const daysCreated = millisCreated / 1000 / 60 / 60 / 24;

		const millisJoined = new Date().getTime() - member.joinedAt.getTime();
		const daysJoined = millisJoined / 1000 / 60 / 60 / 24;


		const embed = new RichEmbed()
			.setTitle(`${user.tag} | ${user.id}`)
			.setDescription('This message will be deleted in 3 minutes')
			.setColor(config.discord.defaultColor)
			.addField('Status', `${user.presence.status[0].toUpperCase() + user.presence.status.slice(1)}`, true)
			.addField('Game', `${(user.presence.game && user.presence.game && user.presence.game.name) || 'Not playing a game.'}`, true)
			.addField('Created On', `${dateFormat(user.createdAt)}`, true)
			.addField('Days Since Creation', `${daysCreated.toFixed(0)}`, true)
			.addField('Joined On', `${dateFormat(member.joinedAt)}`, true)
			.addField('Days Since Joining', `${daysJoined.toFixed(0)}`, true)
			.setFooter(client.config.strings.github)
			.setThumbnail(user.avatarURL)
			.setTimestamp();
		return message.edit({ embed }).then(message.delete(180000));
	}
};
