<template>
	<div>
		<parallax id="parallax-custom">
			<img src="../../assets/para2.jpg" alt="parallax image" />
		</parallax>
		<br />
		<!-- use the modal component, pass in the prop -->
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
				<!-- TODO show loading-->
				<div v-if="noProjects">No projects found</div>
				<project-card v-for="project in filteredProjects"
								:project="project"
								:key="project.id"
								@clickedProject="setProject"
								class="col-xs-12 col-sm-6 col-md-4 col-lg-3"></project-card>
			</div>
		</div>
		<project-details-modal v-if="showModal" @close="showModal = false" :project="projectDetails"></project-details-modal>
	</div>
</template>
<script src="./home.ts"></script>
<style src="./home.css"></style>