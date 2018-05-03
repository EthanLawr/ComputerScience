const Logger = require('../functions/logger');
const config = require('../config');
const util = require('util');
const evalthingy = (text) => {
	if (typeof text !== 'string')
		text = util.inspect(text, {depth: 0})
		text = text
			.replace(/`/g, "`" + String.fromCharCode(8203))
			.replace(/@/g, "@" + String.fromCharCode(8203))
			.replace(config.discord.token, "--DISCORD TOKEN--");
		return text;
};

  
module.exports = {
	commands: [
		'eval'
	],
	usage: 'eval <code>',
	description: 'Evaluate javascript code.',
	category: 'Utility',
	execute: async (client, message, args) => {	
		try {
			const Input = await args.join(" ");
			let evaluation = evalthingy(await eval(Input));
			if (typeof evaluation !== "string")
				evaluation = await util.inspect(evaluation);

				message.edit("Input\n```js\n"+Input+"\n```\n"+"Output\n```js\n"+evalthingy(evaluation)+"\n```", await {Input:"xl"});
		} catch (err) {
			message.edit('Error:\n```js\n'+`${evalthingy(err)}`+'\n```');
			return Logger.warn(err)
		}
	}
};

