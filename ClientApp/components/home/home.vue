<template>
	<div>
		<parallax id="parallax-custom">
			<img src="https://lh3.googleusercontent.com/CW3JSPGe__mAJOQd1p8dn8Q3VNLGaisQzKxVkMSmj3O5IaKWfnkdTv6ln6SUI7susIzJGAvmGGg8rUX4l5RHgMS_XyrTwxI5M9A1CEUcWRVZgqAmbWxspXyqGYjdrF_l7aLWKXrL4sRgYAG4c2a6lAnxalkQ6iojk0TWmlt-suOLHWPGmbCw5ZZRkSjBf99OoBiCwaDAm_QR20RZ_2s3-Qu3BOlPYoMIxA3wqMSD3LtyRNdSZImmn2son4zpG0uR-SMb9sq1wogNzuphXSIjG7kaad6z5_4B_tINWXSCH-Rbxpl2YlfyoK02Qdgr7HNTZ084iu-6tCsuZlEK26sZ0ZjqOCgxQRjkRwnEYVqQ3yCbw0MtRr9Ue3zBJClM07hfSiDl8g7hN54NUmr5B_8PKJGgcbzmSzn7sJTDq5U1RfKu4dC361wXUML-SQ6P_5G0o6woaMSOjLVJNsiHURsxQ9nAe-2f6C1lWUqnclqAKyy1BjvhbxN1IpqajxLtvi-blX7lLwaK9r7jbvdUE_uZ8GPstoUKgzg_q3Fo5awvaIV2c650VpJVXgHwAwlJCg1mrVGpzOB4nYisexG-RDeHBBTUqWZAqulPhW8mad4igPtMLn8VDMXg98wlDD537_ul1r20N4GOzKXBKqm-5Mz3e360RdpLX4aBUZs=w1964-h1309-no" alt="parallax image" />
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