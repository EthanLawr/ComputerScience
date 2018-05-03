const dateFormat = require('dateformat');
const { RichEmbed } = require('discord.js');
const config = require('../config');

module.exports = {
	commands: [
		'serverinfo',
		'sinfo'
	],
	usage: 'serverinfo',
	description: 'Get information on the current server.',
	category: 'Information',
	execute: (client, message) => {

		if (!message.guild) {
			message.edit('**This can only be used in a guild!**');
		}

		const millis = new Date().getTime() - message.guild.createdAt.getTime();
		const days = millis / 1000 / 60 / 60 / 24;
		const owner = message.guild.owner.user || {};
		const verificationLevels = [
			'None',
			'Low',
			'Medium',
			'Insane',
			'Extreme'
		];

		const embed = new RichEmbed()
			.setTitle(`${message.guild.name}`)
			.setDescription('This message will be deleted in 3 minutes')
			.addField('Created On', `${dateFormat(message.guild.createdAt)}`, true)
			.addField('Days Since Creation', `${days.toFixed(0)}`, true)
			.addField('Region', `${message.guild.region}`, true)
			.addField('Member Count', `${message.guild.members.filter((member) => member.presence.status !== 'offline').size} / ${message.guild.memberCount}`, true)
			.addField('Owner', `${owner.username || 'None'}`, true)
			.addField('Text Channels', `${message.guild.channels.filter((member) => member.type === 'text').size}`, true)
			.addField('Voice Channels', `${message.guild.channels.filter((member) => member.type === 'voice').size}`, true)
			.addField('Verification Level', `${verificationLevels[message.guild.verificationLevel]}`, true)
			.addField('Roles', `${(() => {
					const roles = message.guild.roles.map(r => r.toString()).join(', ');
					if (roles.length > 1023) return 'A lot of roles!';
					return roles; 
					})()}`, false)
			.setFooter(client.config.strings.github)
			.setColor(config.discord.defaultColor)
			.setTimestamp();
		message.edit({ embed }).then(message.delete(180000));
	}
};
