module.exports = {
	commands: [
		'ping',
		'pang',
		'pong',
		'pung',
		'peng'
	],
	usage: 'ping',
	description: 'Shows your current ping!',
	category: 'Information',
	execute: (client, message) => {
		message.channel.send('Pong').then(msg => {
		msg.edit('Ping: `' + `${msg.createdTimestamp - message.createdTimestamp}` + 'ms`');
		});
		message.delete();
	}
};


