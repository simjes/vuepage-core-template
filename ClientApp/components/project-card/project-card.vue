<template>
	<div class="project-card" @click="emitProjectDetails($event)">
		<!-- TODO: replace attributes with event emit to parent? -->
		<div class="thumbnail text-center" data-toggle="modal" data-target="#projectModal">
			<img class="project-image" src="https://unsplash.it/1000/1000/?random" alt="project image" />
			<h5>{{project.title}}</h5>
		</div>
	</div>
</template>

<script src="./project-card.ts"></script>
<style src="./project-card.css" scoped></style>