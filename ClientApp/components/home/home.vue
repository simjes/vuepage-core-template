<template>
	<div>
		<parallax id="parallax-custom">
			<img src="https://unsplash.it/1000/500/?image=0" alt="very cool bg" />
		</parallax>
		<br />
		
		<!-- TODO: fix parallax stuff-->
		<div style="margin-top:500px;">
			<!-- Might make these components in the future for easier additions, but atm YAGNI -->
			<div class="row text-right">
				<div class="checkbox-custom">
					<label class="checkbox" for="mobileCheckbox">
						<input type="checkbox" data-toggle="checkbox" id="mobileCheckbox" v-model="showMobile" />
						Mobile
					</label>
				</div>
				<div class="checkbox-custom">
					<label class="checkbox" for="webCheckbox">
						<input type="checkbox" data-toggle="checkbox" id="webCheckbox" v-model="showWeb" />
						Web
					</label>
				</div>
				<div class="checkbox-custom">
					<label class="checkbox" for="backendCheckbox">
						<input type="checkbox" data-toggle="checkbox" id="backendCheckbox" v-model="showBackend" />
						Backend
					</label>
				</div>
				<div class="checkbox-custom">
					<label class="checkbox" for="othersCheckbox">
						<input type="checkbox" data-toggle="checkbox" id="othersCheckbox" v-model="showOthers" />
						Other
					</label>
				</div>
			</div>
			<div class="row">
				<project-card v-for="project in filteredProjects" 
							  :project="project" 
							  :key="project.id"
							  class="col-xs-12 col-sm-6 col-md-4 col-lg-3"></project-card>
			</div>
			<h1 >Hello, world!</h1>
			<p>Welcome todsadsdasd your new single-page application, built with:</p>
			<ul>
				<li><a href="https://get.asp.net/">ASP.NET Core</a> and <a href="https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx">C#</a> for cross-platform server-side code</li>
				<li><a href="https://vuejs.org/">Vue.js</a> and <a href="http://www.typescriptlang.org/">TypeScript</a> for client-side code</li>
				<li><a href="https://webpack.github.io/">Webpack</a> for building and bundling client-side resources</li>
				<li><a href="http://getbootstrap.com/">Bootstrap</a> for layout and styling</li>
			</ul>
			<p>To help you get started, we've also set up:</p>
			<ul>
				<li><strong>Client-side navigation</strong>. For example, click <em>Counter</em> then <em>Back</em> to return here.</li>
				<li><strong>Webpack dev middleware</strong>. In development mode, there's no need to run the <code>webpack</code> build tool. Your client-side resources are dynamically built on demand. Updates are available as soon as you modify any file.</li>
				<li><strong>Hot module replacement</strong>. In development mode, you don't even need to reload the page after making most changes. Within seconds of saving changes to files, your Vue app will be rebuilt and a new instance injected is into the page.</li>
				<li><strong>Efficient production builds</strong>. In production mode, development-time features are disabled, and the <code>webpack</code> build tool produces minified static CSS and JavaScript files.</li>
			</ul>
			</div>
	</div>
</template>
<script src="./home.ts"></script>
<style src="./home.css"></style>