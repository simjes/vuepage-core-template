<template>
	<div id="modal-template">
		<transition name="modal" >
			<div class="modal-mask">
				<div class="modal-wrapper" @click.self="$emit('close')" >
					<div id="modal-holder" class="modal-container" v-on:keyup.esc="$emit('close')" tabindex="-1">
						<div class="modal-header">
							<button type="button" class="close" @click="$emit('close')" aria-label="Close" ><span aria-hidden="true">&times;</span></button>
							<h3>{{project.title}}</h3>
						</div>

						<div class="modal-body">
							<div class="text-center">
								<img class="project-details-image" :src="project.imageUrl" />
							</div>
							<div class="description-container">
								{{project.description}}
							</div>
							<div class="tag-container">
								Tags:
								<div v-for="tag in project.tags" class="tag">
									<span class="tag-name">{{tag.name}}</span>
								</div>
							</div>
							<div class="text-right">
								<div class="label-location" v-for="link in project.urlLocation">
									<!-- TODO: style -->
									<a :href="link.url" target="_blank"><span class="label label-default label-custom">{{link.name}}</span></a>
								</div>
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