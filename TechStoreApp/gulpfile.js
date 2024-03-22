/// <binding AfterBuild='default' Clean='clean' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');

const nodeRoot = '../node_modules/';
const targetPath = './wwwroot/lib/';

gulp.task('default', function () {
	gulp.src(nodeRoot + "jquery/dist/jquery.js").pipe(gulp.dest(targetPath + "/jquery/dist"));
	gulp.src(nodeRoot + "jquery/dist/jquery.min.js").pipe(gulp.dest(targetPath + "/jquery/dist"));
	gulp.src(nodeRoot + "jquery/dist/jquery.min.map").pipe(gulp.dest(targetPath + "/jquery/dist"));

	gulp.src(nodeRoot + "jquery-validation/dist/*.js").pipe(gulp.dest(targetPath + "/jquery-validation/dist"));

	gulp.src(nodeRoot + "jquery-validation-unobtrusive/dist/*.js").pipe(gulp.dest(targetPath + "/jquery-validation-unobtrusive"));
});
