module.exports = client => {
  Logger.start(`User: ${client.user.tag} (${client.user.id})\n\t\t\t\tGuilds: ${client.guilds.size}\n\t\t\t\t` +
    `Channels: ${client.channels.size}\n\t\t\t\tPrefix: ${config.discord.prefix}\n\t\t\t\tDefault Color: ` +
	`${config.discord.defaultColor}`);

  client.user.setGame('js.help | Yosh is cool or something', 'https://twitch.tv/twitch');
  
}; 

