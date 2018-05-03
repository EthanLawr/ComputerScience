/* eslint no-undef: "off", prefer-template: "off", brace-style: "off",
no-cond-assign: "off", no-constant-condition: "off" */
const util = require('util');
function clean(client, text) {
	if (typeof(text) === "string") {
		return text.replace(/`/g, "`" + String.fromCharCode(8203))
		.replace(/@/g, "@" + String.fromCharCode(8203))
		.replace(config.discord.token, "-----NO TOKEN FOR YOU-----");
	}
	else {
		return text;
	}
}

module.exports = {
  commands: [
    'eval',
  ],
  usage: 'eval <code>',
  description: 'Evaluate some dudes code if they are besties with Stan.',
  category: 'Owner',
  execute: async (client, message, args) => {
    Logger.debug('Started Evaluation');
    if (message.author.id = '250815960250974209') {
      let code = await args.join(' ');
      try {
        let ev = require('util').inspect(eval(code));
        if (ev.length > 1950) {
          ev = ev.substr(0, 1950);
        }
        let token = config.token;
        let re = new RegExp(token, 'g');
        ev = clean(re);
        await message.channel.send('**Input:**```js\n' + code + '```**Eval:**```js\n' + ev + '```');
      } catch (err) {
        await message.channel.send('```js\n' + err + '```');
        return Logger.error(util.inspect(err));
      }
    } else {
      return message.channel.send('Stan Incorporated has prohibited you from using this command!');
    }
    return Logger.debug('Finished Evaluation');
  },
};

/*	Half Chips Half Me
		if(message.author.id = '250815960250974209') {
			try {
				let evaled = await eval(message.content.slice('.eval '.length));
				if (typeof evaled !== "string") evaled = require("util").inspect(evaled);
				message.channel.sendCode("xl", evaled).catch(console.error);
				}
			catch(err) {
				message.channel.sendCode("xl", err.toString()).catch(console.error);
				Logger.error(util.inspect(err));
			}
		} else {
			message.channel.send("Stan Incorporated has prohibited you from using this command!");
		}
	}
}; */

/*	fuck up
		if(message.author.id = '250815960250974209') {
			const code = args.join(" ");
			Logger.log(code);
			try {
				const evaled = evalthingy(await eval(code));
				Logger.log(evaled);
				message.channel.send(`\`\`\`xl\n${evaled}\n\`\`\``
				);
			}
			catch(err) {
				message.channel.send(`\`ERROR\` \`\`\`xl\n${evalthingy(err)}\n\`\`\``);
				Logger.error(util.inspect(err));
			}
		} else {
			message.channel.send("Stan Incorporated has prohibited you from using this command!");
		}
	}
}; */

/*	const whitelist = [
	'250815960250974209',
	'365972456139390977'
];

const util = require('util');

function clean(client, text) {
	if (typeof(text) === "string") {
		return text.replace(/`/g, "`" + String.fromCharCode(8203))
		.replace(/@/g, "@" + String.fromCharCode(8203))
		.replace(config.discord.token, "-----NO TOKEN FOR YOU-----");
	}
	else {
		return text;
	}
}*/

/*	Evie
		message.flags = [];
		if(message.author.id = '250815960250974209') {
			const code = args.join(" ");
			try {
				const evaled = clean(await eval(code));
				if(message.flags.includes("d")) message.delete();
				if(message.flags.includes("s")) return;
				message.channel.send(`\`\`\`xl\n${evaled}\n\`\`\``);
			}
			catch(err) {
				if(message.flags[0] && message.flags[0] === 's')
					return message.delete();
				message.channel.send(`\`ERROR\` \`\`\`xl\n${clean(err)}\n\`\`\``);
			}
		} else {
			message.channel.send("Stan Incorporated has prohibited you from using this command!");
		}
	}
};*/
