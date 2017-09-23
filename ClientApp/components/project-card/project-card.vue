<template>
	<div class="project-card" @click="emitProjectDetails($event)">
		<!-- TODO: replace attributes with event emit to parent? -->
		<div class="thumbnail text-center project-card-content" data-toggle="modal" data-target="#projectModal">
			<img class="project-image" :src="project.thumbnailUrl" alt="project image" />
			<h6 class="project-card-title">{{project.title}}</h6>
		</div>
	</div>
</template>

<script src="./project-card.ts"></script>
<style src="./project-card.css" scoped></style>