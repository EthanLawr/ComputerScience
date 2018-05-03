const util = require('util');

const cunt = async (client, text) => {
  if (text && text.constructor.name === 'Promise') text = await text;
  if (typeof evaled !== 'string') text = util.inspect(text, { depth: 1 });

  text = text
      .replace(/`/g, `\`${String.fromCharCode(8203)}`)
      .replace(/@/g, `@${String.fromCharCode(8203)}`)
      .replace(global.config.discord.token, 'mfa.VkO_2G4Qv3T--NO--lWetW_tjND--TOKEN--QFTm6YGtzq9PH--4U--tG0');

  return text;
};


module.exports = {
  commands: [
    'eval',
  ],
  usage: 'eval <code>',
  description: 'Evaluate some dudes code',
  category: 'Owner',
  execute: async(client, message, args) => {
    global.Logger.debug('Started Evaluation');
    if (!message.author.id === '250815960250974209') {
      return message.channel.send('Only Evildeathpro can do this! Please contact him if it needs to be done!');
    }

    const code = args.join(' ');
    try {
      const evaled = eval(code);
      const kys = await cunt(client, evaled);
      message.channel.send(`\`\`\`js\n${kys}\n\`\`\``);
    } catch (err) {
      message.channel.send(`\`ERROR\` \`\`\`xl\n${await cunt(client, err)}\n\`\`\``);
    }
    return global.Logger.debug('Finished Evaluation');
  },

};
