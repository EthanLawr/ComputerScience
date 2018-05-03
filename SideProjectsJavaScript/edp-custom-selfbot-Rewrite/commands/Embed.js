const { RichEmbed } = require('discord.js');
const Logger = require('../functions/logger');
const config = require('../config');

module.exports = {
	commands: [
		'embed',
		'embedsay',
		'emb',
		'say',
		'esay'
	],
	usage: 'embedsay <texthere>',
	description: 'Takes words you put in and Puts them in a embed!',
	category: 'Other',
	execute: (client, message, args) => {
		messageArgs=message.content.split(' ');
		if(!args) {
			const embed = new RichEmbed()
				.setDescription('_ _')
				.setColor(config.discord.defaultColor);
			message.channel.send('', { embed: embed });
		} else {
			Logger.contents(`${args.join(' ')}`);
			const embed = new RichEmbed()
				.setDescription(`${args.join(' ')}`)
				.setColor(config.discord.defaultColor);
			message.channel.send('', { embed: embed });
		}
		message.delete();
	}
};

/*
			
		let message = message.content.substring(message.content.indexOf(" ")+1,message.content.length);
		var embed = new RichEmbed()


		message = (message.substring(message.indexOf(" ")));;
		message.channel.send('', { embed: embed });
		*/


/*const { RichEmbed } = require('discord.js');
const Logger = require('../functions/logger');

module.exports = {
	commands: [
		'embed',
		'embedsay',
		'emb',
		'say',
		'esay'
	],
	usage: 'embedsay <texthere>',
	description: 'Takes words you put in and Puts them in a embed!',
	category: 'Other',
	execute: (client, message, args) => {
		Logger.cmd("Embed")
		if (args.length > 0) {
			const embed = new RichEmbed()
				.setTitle(args.join(' '));
			message.edit({embed});
		} else {
			return message.edit('**Add something after the command silly!**');
		}
	}
}*/
