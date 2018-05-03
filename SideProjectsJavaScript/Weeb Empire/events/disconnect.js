module.exports = (client, event) => {
  setTimeout(() => client.destroy().then(() => client.login(global.config.discord.token)), 10000);
  global.Logger.log(`[DISCONNECT] Notice: Disconnected from gateway with code ${event.code} - Attempting reconnect.`);
};
