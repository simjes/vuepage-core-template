import {ProjectType} from './ProjectTypes';
import {ITag} from "./Tag";
import {IUrlLocation} from "./UrlLocation";

export interface IProject {
	id: number,
	title: string,
	description: string,
	imageUrl: string,
	thumbnailUrl: string,
	startDateTime: string,
	tags: ITag[], //todo: remove when automap, should only be string without ID
	urlLocation: IUrlLocation[], //todo: consistent naming: plural or not
	projectType: ProjectType,
}