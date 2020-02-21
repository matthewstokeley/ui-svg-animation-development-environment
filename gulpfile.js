const runner = require( 'gulp' )

runner.task( 'concat', () => {

	return runner.src( '' )
		.pipe()
		.dest()

} )

runner.series( 'build'. [ 'concat' ] )