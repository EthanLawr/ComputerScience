module.exports = {
  commands: [
    'shutdown',
    'die',
    'kys',
    'sd',
    'fuckoff',
    'kms',
  ],
  usage: 'shutdown',
  description: 'Shuts the bot off',
  category: 'Owner',
  execute: ( client, message ) =>
  {
    message.reply( 'Shutting down!' )
      .then( Logger.start( 'Shutting down.....' ) )
      .then( process.exit( 1 ) );
  },
};