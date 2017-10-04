<template>
	<div class="navbar-container">
		<div class="navbar navbar-fixed-top navbar-inverse navbar-custom">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
					<span class="sr-only">Toggle navigation</span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
				</button>
				<a id="brand-name" class="navbar-brand" href="/">SimFolio</a>
			</div>
			<!--<div class="clearfix"></div>-->
			<div class="navbar-collapse collapse">
				<ul class="nav navbar-nav">
					<li>
						<router-link to="/" :exact="true">
							<span class="navbar-custom-text"><span class="glyphicon glyphicon-home"></span> Home</span>
						</router-link>
					</li>
					<li>
						<router-link to="/about">
							<span class="navbar-custom-text"><span class="glyphicon glyphicon-user"></span> About</span>								
						</router-link>
					</li>
				</ul>
			</div>
		</div>
	</div>
</template>

<style src="./navmenu.css" ></style>
