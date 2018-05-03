const Logger = require('../functions/logger');

module.exports = {
	commands: [
		'shutdown',
		'killmyself',
		'poweroff',
		'sd'
	],
	usage: 'shutdown',
	description: 'Shuts the client down',
	category: 'Utility',
	execute: async (client, message, args) => {
	 
	let count = parseInt(args[0]) || 1;

    message.delete();
    message.channel.fetchMessages({ limit: Math.min(count, 100), before: message.id })
        .then(messages => {
            Promise.all(messages.map(m => m.delete()))
                .catch(message.error);
        }).catch(message.error);
	}
};
