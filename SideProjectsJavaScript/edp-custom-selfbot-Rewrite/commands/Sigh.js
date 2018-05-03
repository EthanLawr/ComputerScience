const Logger = require('../functions/logger');

const sigh = "" +
"```fix\n" +
"  _______   _________    _________   ,        ,\n" +
" /              |       /            |        |\n" +
"|               |      |             |        |\n" +
"|               |      |             |        |\n" +
" \\_____,        |      |  _______,   |________|\n" +
"        \\       |      |         |   |        |\n" +
"         |      |      |         |   |        |\n" +
"         |      |      |         |   |        |\n" +
"  ______/   ____|____   \\________|   |        |\n" +
"\u200b\n" +
"```";

module.exports = {
	commands: [
		'sigh'
	],
	usage: 'sigh',
	description: '*Sighs*',
	category: 'Fun',
	execute: (client, message) => {
		Logger.cmd("Sigh");
		message.edit(sigh);
	}
};

