#  @version 0.2.1
#  ~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-
#  Module Declarations 

runner   = require 'gulp'
babel    = require 'babel'

#  ~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-
#  Tasks

runner.task  'transpile', () ->
	runner.src ''
	.pipe babel ''
	.dest ''


#  ~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-
#  Series

runner.series 'build', [ 'concat' ]

