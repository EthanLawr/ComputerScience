module.exports = {
  commands: [
    'ping',
  ],
  usage: 'ping <action>',
  description: 'Shows how fast Weeb Empire Bot is!',
  category: 'Information',
  execute: async(client, message, args) => {
    // No Arguments; Base Command
    if (!args[0]) {
      return message.channel.send('Pong').then(msg => {
        msg.edit(`Client Ping: \`${msg.createdTimestamp - message.createdTimestamp}` +
        ` ms\`\nWebsocket Ping: \`${client.ping} ms\``);
      });
    } else if (args[0] === 'help' | 'actions') {
      return message.channel.send('The following actions are availible for the Ping command' +
      `:\n**${global.config.discord.prefix}**ping\n**${global.config.discord.prefix}**ping dev\n**${global.config.discord.prefix}` +
      `**ping devping\n**${global.config.discord.prefix}**ping help\n**${global.config.discord.prefix}**ping verbose\n`);
    } else if (args[0] === 'dev' | 'devping' | 'verbose') {
      // Dev
      let wsPing = client.ping;
      let now = Date.now();
      let sentmsg;
      try {
        sentmsg = await message.channel.send('Pong! ');
      } catch (err) {
        return global.Logger.error(`Error at message.channel.sending message of Ping: ${err}`);
      }
      let sendMetrics = Date.now() - now;

      const m = await sentmsg.edit(`Pong!`);
      const editMetrics = m.editedAt - m.createdAt;

      // Const edit1 = m.editedAt;
      // await sentmsg.react('🇭');
      const now2 = Date.now();
      await sentmsg.react('🇭');
      now = Date.now();
      const reactMetrics = (now - now2) / 2;
      let creactMetrics;
      try {
        await sentmsg.clearReactions();
        creactMetrics = Date.now() - now;
      } catch (err) {
        creactMetrics = 'No data could be collected..perhaps I am missing permissions';
      }
      now = Date.now();
      await sentmsg.delete();
      const delMetrics = Date.now() - now;

      let weighted;
      if (!isNaN(creactMetrics)) {
        // Weight: 10%/25%/20%/10%/10%/25%
        weighted = (wsPing / 10) + (sendMetrics / 4) + (editMetrics / 5) + (reactMetrics / 10) +
 (creactMetrics / 10) + (delMetrics / 4);
      } else {
        // Weight: 11%/26%/21%/11%/00%/21%
        weighted = (wsPing * 0.11) + (sendMetrics * 0.26) + (editMetrics * 0.21) + (reactMetrics * 0.11) + (delMetrics * 0.21);
      }

      let scale = '';
      if (weighted < 100) {
        scale = 'That\'s amazing!';
      } else if (weighted < 200) {
        scale = 'That\'s very good!';
      } else if (weighted < 300) {
        scale = 'That\'s pretty decent!';
      } else if (weighted < 400) {
        scale = 'That\'s about average!';
      } else if (weighted < 500) {
        scale = 'That\'s slightly below average!';
      } else if (weighted < 600) {
        scale = 'I might be lagging a bit!';
      } else if (weighted < 700) {
        scale = 'I think I am lagging a fair amount! This might be from Discord\'s end!';
      } else if (weighted < 800) {
        scale = 'Perhaps I am having issues with the internet! Try to find out if its ' +
        'a problem within Discord\'s side!!';
      } else if (weighted < 900) {
        scale = 'That\'s pretty bad! Try to see if it\'s a problem on Discord\'s end!';
      } else if (weighted < 1000) {
        scale = 'That\'s poor! Perhaps I just restarted? Try to see if it\'s a problem on Discord\'s end!';
      } else if (weighted > 1000) {
        scale = 'Help! Something must be wrong with me or Discord! Perhaps I just restarted?' +
        ' Try to see if it\'s a problem on Discord\'s end!';
      }

      let embed = new global.Discord.RichEmbed()
        .setColor(global.config.discord.defaultColor)
        .setTitle('**Ping Metrics**');
      embed.setDescription('This is the Developer Ping command to see specific pings!');
      embed.addField('Connecting to Discord: ', `${wsPing * 2}ms`, true);
      embed.addField('Sending a message: ', `${sendMetrics * 2}ms`, true);
      embed.addField('Editing a message: ', `${editMetrics * 2}ms`, true);
      embed.addField('Reacting to a messsage (rate limit): ', `${reactMetrics * 2}ms`, true);
      embed.addField('Clearing message reactions: ', `${typeof creactMetrics !== 'string' ? creactMetrics * 2 : creactMetrics}ms`, true);
      embed.addField('Deleting a messsage: ', `${delMetrics * 2}ms`, true);
      return message.channel.send(`🏓\u2000 My weighted/overall ping is ${weighted * 2}ms! ${scale}`, { embed });
    } else {
      return message.send('uh contact the dev it broke or something');
    }
  },
};
