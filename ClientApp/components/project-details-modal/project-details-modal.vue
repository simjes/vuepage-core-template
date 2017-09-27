<template>
	<div id="modal-template">
		<transition name="modal">
			<div class="modal-mask">
				<div class="modal-wrapper">
					<div class="modal-container">

						<div class="modal-header">
							<button type="button" class="close" @click="$emit('close')" aria-label="Close" ><span aria-hidden="true">&times;</span></button>
							<h3>{{project.title}}</h3>
						</div>

						<div class="modal-body">
							<div class="text-center">
								<img class="project-details-image" :src="project.imageUrl" />
							</div>
							{{project.description}}
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
		</transition>		
	</div>
</template>

<script src="./project-details-modal.ts"></script>
<style src="./project-details-modal.css" scoped></style>