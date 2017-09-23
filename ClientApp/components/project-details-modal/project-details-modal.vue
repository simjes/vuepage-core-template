<template>
	<div class="modal fade" id="projectModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
		<div class="modal-dialog" role="document">
			<div class="modal-content modal-custom">
				<div class="modal-header">
					<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
					<h4 class="modal-title" id="projectTitle">{{project.title}}</h4>
				</div>
				<div class="modal-body">
					<div class="text-center">
						<img class="project-details-image" :src="project.imageUrl" />
					</div>
					
					{{project.description}}
					<!--TODO: this is for dev
					<br />
					<br />
					<br />
					{{project}}
					TODO: this is for dev-->
				</div>
				<div class="modal-footer">
					<div class="label-location" v-for="link in project.urlLocation">
						<!-- TODO: style -->
						<a :href="link.url" target="_blank"><span class="label label-default">{{link.name}}</span></a>
					</div>
				</div>
			</div>
		</div>
	</div>
</template>

<script src="./project-details-modal.ts"></script>
<style src="./project-details-modal.css" scoped></style>