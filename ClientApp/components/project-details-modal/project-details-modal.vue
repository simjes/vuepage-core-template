<template>
	<div class="modal fade" id="projectModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
		<div class="modal-dialog" role="document">
			<div class="modal-content modal-custom">
				<div class="modal-header">
					<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
					<h4 class="modal-title" id="projectTitle">{{project.title}}</h4>
				</div>
				<div class="modal-body">
					<img class="project-details-image" src="https://unsplash.it/1000/500/?random" />
					{{project}}
				</div>
				<div class="modal-footer">
					<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
					<button type="button" class="btn btn-primary">Send message</button>
				</div>
			</div>
		</div>
	</div>
</template>

<script src="./project-details-modal.ts"></script>
<style src="./project-details-modal.css"></style>